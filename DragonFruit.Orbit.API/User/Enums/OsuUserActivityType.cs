// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using DragonFruit.Orbit.Api.Utils;

namespace DragonFruit.Orbit.Api.User.Enums
{
    public enum OsuUserActivityType
    {
        [ExternalValue("achievement")]
        AchievementUnlocked,

        [ExternalValue("beatmapPlaycount")]
        BeatmapPlayCount,

        [ExternalValue("beatmapsetApprove")]
        BeatmapsetApproved,

        [ExternalValue("beatmapsetDelete")]
        BeatmapsetDeleted,

        [ExternalValue("beatmapsetRevive")]
        BeatmapsetRevived,

        [ExternalValue("beatmapsetUpload")]
        BeatmapsetUpload,

        [ExternalValue("beatmapsetUpdate")]
        BeatmapsetUpdate,

        [ExternalValue("rank")]
        RankAchieved,

        [ExternalValue("rankLost")]
        RankLost,

        [ExternalValue("userSupportAgain")]
        UserSupportAgain,

        [ExternalValue("userSupportFirst")]
        UserSupportFirst,

        [ExternalValue("userSupportGift")]
        UserSupportGift,

        [ExternalValue("usernameChange")]
        UsernameChange
    }
}
