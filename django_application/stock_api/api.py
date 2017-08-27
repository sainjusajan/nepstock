from rest_framework import viewsets

from .models import StockData
from .serializers import StockDataSerializer


class StockDataViewSet(viewsets.ModelViewSet):
    serializer_class = StockDataSerializer
    queryset = StockData.objects.all()