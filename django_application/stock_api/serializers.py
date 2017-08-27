from .models import StockData

from rest_framework import serializers


class StockDataSerializer(serializers.ModelSerializer):
    class Meta:
        model = StockData
        fields = ('companyName', 'companyAbbr', 'date', 'open', 'high','low', 'close', 'adjClose', 'volume')