from django.db import models

# from django.conf import settings

# Create your models here.
class StockData(models.Model):
    """Model definition for StockEntity."""
    # SN = models.AutoField(primary_key= True)
    companyName = models.CharField(max_length=255)
    companyAbbr = models.CharField(max_length=255)
    date = models.CharField(max_length=255)
    open = models.FloatField()
    high = models.FloatField()
    low = models.FloatField()
    close = models.FloatField()
    adjClose = models.FloatField()
    volume = models.FloatField()

    
    def __str__(self):
        """Unicode representation of StockEntity."""
        return str(self.volume)


