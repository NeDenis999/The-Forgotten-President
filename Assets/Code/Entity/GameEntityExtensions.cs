﻿using Code.Services;
using static Code.Common.StaticCleaners;

namespace Code.Entity
{
    public static class GameEntityExtensions
    {
        public static GameEntity WindUpDuration(this GameEntity entity)
        {
            if (!entity.hasDuration)
                return entity;

            entity.isDurationUp = false;
            entity.ReplaceDurationLeft(entity.duration.Value);

            return entity;
        }

        public static GameEntity WindUpDuration(this GameEntity entity, float duration)
        {
            entity.isDurationUp = false;
            entity.ReplaceDuration(duration);
            entity.ReplaceDurationLeft(duration);

            return entity;
        }

        public static GameEntity WithNewGeneralId(this GameEntity entity)
        {
            if (entity.hasId)
                return entity;

            entity.AddId(Game().identifiers.Value.Next(Identity.General));
            return entity;
        }

        public static GameEntity MarkDestructed(this GameEntity entity)
        {
            if (entity.isDestructed)
                return entity;

            entity.isDestructed = true;
      
            return entity;
        }
    }
}