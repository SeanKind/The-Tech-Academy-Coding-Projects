from django.db import models


class djangoClasses(models.Model):
    Title = models.CharField(max_length=30)
    CourseNumber = models.IntegerField()
    InstructorName = models.CharField(max_length=50)
    Duration = models.FloatField()

    objects = models.Manager()


    def __str__(self):
        return self.Title
