from django.shortcuts import render
from .forms import UploadCsvFileForm
from django.contrib.auth.decorators import login_required
from django.http import HttpResponseRedirect, HttpResponse, JsonResponse
from django.core.urlresolvers import reverse
from .models import StockData
import csv
from django.core.files.storage import FileSystemStorage
from django.conf import settings
import os


from rest_framework.renderers import JSONRenderer
from rest_framework.parsers import JSONParser

from .models import StockData
from .serializers import StockDataSerializer

# Create your views here.


# @login_required
def upload_file(request):
    if request.method == 'POST':
        form = UploadCsvFileForm(request.POST, request.FILES)  
        if form.is_valid():
            tempFile = request.FILES['csvFile']
            fs = FileSystemStorage()
            filename = fs.save(tempFile.name, tempFile)
            companyName = form.cleaned_data['companyName']
            companyAbbr = form.cleaned_data['companyAbbr']
            dataReader = csv.reader(open(os.path.join(settings.MEDIA_ROOT, filename)), delimiter=',', quotechar='"')                    

            for i, row in enumerate(dataReader):
                if i == 0:
                    pass
                else:
                    print(row)
                    stockData = StockData()
                    stockData.companyName = companyName
                    stockData.companyAbbr = companyAbbr
                    stockData.date = row[0]
                    stockData.open = float(row[1])
                    stockData.high = float(row[2])
                    stockData.low = float(row[3])
                    stockData.close = float(row[4])
                    stockData.adjClose = float(row[5])
                    stockData.volume = float(row[6])
                    stockData.save()
        else:
            print(UploadCsvFileForm.errors)
    else:
        form = UploadCsvFileForm()

    return render(request, 'stock_api/index.html', {'uploadcsv_form': form})
            

class StockdataJSONResponse(HttpResponse):
    def __init__(self, data, **kwargs):
        content = JSONRenderer().render(data)
        kwargs['content_type'] = 'application/json'
        super(StockdataJSONResponse, self).__init__(content, kwargs)


def stock_data_list(request):
    if request.method == 'GET':
        if request.GET.get('company_abbr'):
            stockData = StockData.objects.filter(companyAbbr=request.GET.get('company_abbr'))
            serializer = StockDataSerializer(stockData, many=True)
            return StockdataJSONResponse(serializer.data)
        else:
            stockData = StockData.objects.all()
            serializer = StockDataSerializer(stockData, many=True)
            return StockdataJSONResponse(serializer.data)
        


from .models import StockData
from django_pandas.io import read_frame
import matplotlib.pyplot as plt
import numpy as np
import pandas as pd
from sklearn import datasets, linear_model
from sklearn.metrics import mean_squared_error, r2_score



def prediction(request):
    template = 'stock_api/prediction.html'
    # filtering company
    kun_company = request.GET.get('company_abbr')
    qs = StockData.objects.filter(companyAbbr=kun_company)  # RUSSELL 2000 INDEX(company name)
    df = read_frame(qs)
    data = df['open']
    stock_data = np.array(data.values.reshape((len(data), 1)))
    stock_data.shape  # (1258, 1)
    # Split the data into training/testing sets
    stock_X_train = stock_data[:350]
    stock_X_test = stock_data[700:979, ]

    # Split the targets into training/testing sets
    stock_y_train = stock_data[350:700]
    stock_y_test = stock_data[979:]

    regr = linear_model.LinearRegression()
    regr.fit(stock_X_train, stock_y_train)
    stock_y_pred = regr.predict(stock_X_test)
    # stock_y_pred stock_X_test

    # # Statistical parameter
    # #coefficients
    # coefficients = regr.coef_
    # # mean squared error
    # MSE = mean_squared_error(mark_y_test, mark_y_pred)
    # # Explained variance score: 1 is perfect prediction
    # RSQ = r2_score(mark_y_test, mark_y_pred)

    # mark_y_pred_pd = pd.DataFrame(mark_y_pred.reshape(mark_y_pred.shape[1], -1), index=exam, columns=subject)
    # mark_X_test_pd = pd.DataFrame(mark_y_test.reshape(mark_y_test.shape[1], -1), index=exam, columns=subject)
    stock_y_pred_html = stock_y_pred#.to_html()
    stock_X_test_html = stock_X_test#.to_html()
    # plt.plot(stock_y_pred)
    # plt.plot(stock_X_test)

    print(stock_data[-1])
    last_data = regr.predict(stock_data[-1])
    print(last_data)
    

    context = {
        # 'MSE':MSE,
        # 'RSQ':RSQ,
        # 'coefficients':coefficients,
        'stock_y_pred_html': stock_y_pred_html,
        'stock_X_test_html': stock_X_test_html,
    }
    # return render(request, template, context)
    return JsonResponse({'tomorrow_predicted_value': last_data[0][0]})
