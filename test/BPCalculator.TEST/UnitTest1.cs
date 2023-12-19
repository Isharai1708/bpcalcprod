using System;
using Xunit;

using BPCalculator;

namespace BPCalculator.TEST;


public class UnitTest1
{
    [Fact]
    public void TestIdealBloodPressure()
    {
        // Arrange
        BloodPressure bloodPressure = new BloodPressure
        {
            Systolic = 120,
            Diastolic = 80
        };

        // Act
        BPCategory category = bloodPressure.Category;

        // Assert
        Assert.Equal(BPCategory.Ideal, category);
    }
 


    [Fact]
    public void TestPreHighBloodPressureCategory()
    {
        // Arrange
        BloodPressure bloodPressure = new BloodPressure
        {
            Systolic = 140,
            Diastolic = 80
        };

        // Act
        BPCategory category = bloodPressure.Category;

        // Assert
        Assert.Equal(BPCategory.PreHigh, category);
    }
 


[Fact]
public void TestBloodPressureCategory()
{
    // Arrange
    BloodPressure bloodPressure = new BloodPressure();
    bloodPressure.Systolic = 120;
    bloodPressure.Diastolic = 90;

    // Act
    BPCategory category = bloodPressure.Category;

    // Assert
    Assert.Equal(BPCategory.PreHigh, category);
} 



    [Fact]
    public void TestHighBloodPressure()
    {
        // Arrange
        BloodPressure bloodPressure = new BloodPressure
        {
            Systolic = 140,
            Diastolic = 90
        };

        // Act
        BPCategory category = bloodPressure.Category;

        // Assert
        Assert.Equal(BPCategory.High, category);
    }
 



    [Fact]
    public void TestLowBloodPressure()
    {
        // Arrange
        BloodPressure bloodPressure = new BloodPressure
        {
            Systolic = 70,
            Diastolic = 40
        };

        // Act
        BPCategory category = bloodPressure.Category;

        // Assert
        Assert.Equal(BPCategory.Low, category);
    }




    [Fact]
    public void TestSuperHighBloodPressure()
    {
        // Arrange
        BloodPressure bloodPressure = new BloodPressure
        {
            Systolic = 190,
            Diastolic = 100
        };

        // Act
        BPCategory category = bloodPressure.Category;

        // Assert
        Assert.Equal(BPCategory.High, category);
    }




    [Fact]
    public void TestSystolicBelowLowerLimit()
    {
        // Arrange
        BloodPressure bloodPressure = new BloodPressure
        {
            Systolic = 60,
            Diastolic = 80
        };

        // Act
        BPCategory category = bloodPressure.Category;

        // Assert
        Assert.Equal(BPCategory.Low, category);
    }
 



    [Fact]
    public void TestSystolicValueAboveUpperLimit()
    {
        // Arrange
        BloodPressure bloodPressure = new BloodPressure
        {
            Systolic = 200,
            Diastolic = 80
        };

        // Act
        BPCategory category = bloodPressure.Category;

        // Assert
        Assert.Equal(BPCategory.High, category);
    }
 



    [Fact]
    public void TestDiastolicBelowLowerLimit()
    {
        // Arrange
        BloodPressure bloodPressure = new BloodPressure
        {
            Systolic = 120,
            Diastolic = 30
        };

        // Act
        BPCategory category = bloodPressure.Category;

        // Assert
        Assert.Equal(BPCategory.Low, category);
    }
 



    [Fact]
    public void DiastolicValueAboveUpperLimit()
    {
        // Arrange
        BloodPressure bloodPressure = new BloodPressure
        {
            Systolic = 120,
            Diastolic = 110
        };

        // Act
        BPCategory category = bloodPressure.Category;

        // Assert
        Assert.Equal(BPCategory.High, category);
    }
}