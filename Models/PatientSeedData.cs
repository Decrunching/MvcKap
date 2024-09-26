using Microsoft.EntityFrameworkCore;
using MvcKap.Data;

namespace MvcKap.Models
{
    public static class PatientSeedData
    {
        public static void Initialise(IServiceProvider serviceProvider)
        {
            using (var context = new MvcKapContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcKapContext>>()))
            {
                // Look for patients
                if (context.Patient.Any())
                {
                    return; // Seeded the DB
                }
                context.Patient.AddRange(
                    new Patient
                    {
                        Species = "cat",
                        AgeYears = 10,
                        AgeMonths = 2,
                        BodyWeight = 2,
                        LeanBodyWeight = 2,
                        Bcs = 4
                    },
                    new Patient
                    {
                        Species = "cat",
                        AgeYears = 5,
                        AgeMonths = 7,
                        BodyWeight = 3.5,
                        LeanBodyWeight = 3,
                        Bcs = 6
                    },
                    new Patient
                    {
                        Species = "dog",
                        AgeYears = 9,
                        AgeMonths = 0,
                        BodyWeight = 54,
                        LeanBodyWeight = 40,
                        Bcs = 8
                    },
                    new Patient
                    {
                        Species = "dog",
                        AgeYears = 0,
                        AgeMonths = 3,
                        BodyWeight = 1.5,
                        LeanBodyWeight = 1.5,
                        Bcs = 5
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
