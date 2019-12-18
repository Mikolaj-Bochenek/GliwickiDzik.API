using System.Collections.Generic;
using System.Threading.Tasks;
using GliwickiDzik.API.Models;

namespace GliwickiDzik.API.Data
{
    public interface ITrainingRepository : IGenericRepository<TrainingPlanModel>, IGenericRepository<TrainingModel>, IGenericRepository<ExerciseForTrainingModel>
    {
         Task<TrainingPlanModel> GetTrainingPlanAsync(int id);
         Task<IEnumerable<TrainingPlanModel>> GetAllTrainingPlansAsync();
         Task<TrainingModel> GetTrainingAsync(int id);
         Task<IEnumerable<TrainingPlanModel>> GetAllTrainingsAsync();
         Task<ExerciseForTrainingModel> GetExerciseForTrainingAsync(int id);
         Task<IEnumerable<ExerciseForTrainingModel>> GetAllExercisesForTrainingAsync(int trainingId);
         Task<bool> SaveAllTrainings();
    }
}