from django.db import models

# Create your models here.
class Product(models.Model):
    """Model definition for Product."""
    name = models.CharField(max_length=255)
    description = models.TextField()
    price = models.DecimalField(decimal_places=2, max_digits=20)



    def __str__(self):
        """Unicode representation of Product."""
        return self.name


