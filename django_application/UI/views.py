from django.shortcuts import render
from django.views.generic import View, TemplateView, DetailView, ListView
from django.http import HttpResponse
from rest_framework.renderers import JSONRenderer
from rest_framework.parsers import JSONParser
from .models import Product
from .serializers import ProductSerializer

class JSONResponse(HttpResponse):
    """
    An HttpResponse that renders its content to JSON
    """
    def __init__(self, data, **kwargs):
        content = JSONRenderer().render(data)
        kwargs['content_type'] = 'application/json'
        super(JSONResponse, self).__init__(content, kwargs)

def product_list(request):
    if request.method == 'GET':
        products = Product.objects.all()
        serializer = ProductSerializer(products,many = True)
        return JSONResponse(serializer.data)



    

# Create your views here.
class indexView(TemplateView):
    template_name = "UI/index.html"



class companyDetail(TemplateView):
    template_name = "UI/company_detail.html"



class marketList(TemplateView):
    template_name = "UI/market_list.html"


class aboutView(TemplateView):
    template_name = "UI/about.html"



class stockNewsView(TemplateView):
    template_name = "UI/stock_news.html"



class stockNewsDetailView(TemplateView):
    template_name = "UI/stock_news_detail.html"
    
