from django import forms

class UploadCsvFileForm(forms.Form):
    """UploadCsvFileForm definition."""
    # TODO: Define form fields here
    companyName = forms.CharField(max_length=255)
    companyAbbr = forms.CharField(max_length=255)
    csvFile = forms.FileField()

