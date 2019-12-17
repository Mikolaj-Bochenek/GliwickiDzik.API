using GliwickiDzik.API.Models;

namespace GliwickiDzik.API.Data
{
    public interface ITrainingRepository : IGenericRepository<TrainingPlanModel>, IGenericRepository<TrainingModel>, IGenericRepository<ExerciseForTrainingModel>
    {
         
    }
}