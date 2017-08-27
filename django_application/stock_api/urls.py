from django.conf.urls import include, url

from rest_framework.routers import DefaultRouter

from . import api
from . import views

app_name = 'stock_api'

router = DefaultRouter()
router.register('stock', api.StockDataViewSet)

urlpatterns = [
    url(r'^$', views.upload_file, name='index'),
    url(r'^stock_data/$', views.stock_data_list),
    url(r'^prediction/$', views.prediction),

    #   API
    url(r'^api/', include(router.urls)),
]
