from django.contrib import admin
from .models import StockData
# Register your models here.
class StockDataAdmin(admin.ModelAdmin):
    list_display = ('companyName', 'companyAbbr', 'date',)

admin.site.register(StockData, StockDataAdmin)
