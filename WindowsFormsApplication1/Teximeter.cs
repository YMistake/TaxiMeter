using System;

public class TexiMeter
{
    float tariff = 0;
    public float cal_cost(float distance)
    {
        if (distance <= 1)
        {
            tariff = 35;
        }
        else if (distance <= 10)
        {
            tariff = 35 + ((distance - 1) * 5.50f);
        }
        else if (distance <= 20)
        {
            tariff = 35 + (9 * 5.50f) + ((distance - 10) * 6.50f);
        }
        else if (distance <= 40)
        {
            tariff = 35 + (9 * 5.50f) + (10 * 6.50f) + ((distance - 20) * 7.50f);
        }
        else if (distance <= 60)
        {
            tariff = 35 + (9 * 5.50f) + (10 * 6.50f) + (20 * 7.50f) + ((distance - 40) * 8.00f);
        }
        else if (distance <= 80)
        {
            tariff = 35 + (9 * 5.50f) + (10 * 6.50f) + (20 * 7.50f) + (20 * 8.00f) + ((distance - 60) * 9.00f);
        }
        else if (distance > 80)
        {
            tariff = 35 + (9 * 5.50f) + (10 * 6.50f) + (20 * 7.50f) + (20 * 8.00f) + (20 * 9.00f) + ((distance - 80) * 10.50f);
        }
        return tariff;
    }
}

