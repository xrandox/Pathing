﻿using BhModule.Community.Pathing.Content;
using BhModule.Community.Pathing.State;
using Blish_HUD;
using Microsoft.Xna.Framework;
using TmfLib.Pathable;
using TmfLib.Prototype;

namespace BhModule.Community.Pathing.Entity {
    public partial class StandardMarker : PathingEntity {

        private static readonly Logger Logger = Logger.GetLogger<StandardMarker>();
        
        public override float DrawOrder => Vector3.DistanceSquared(this.Position, GameService.Gw2Mumble.PlayerCamera.Position);

        public TextureResourceManager TextureResourceManager { get; }

        public StandardMarker(IPackState packState, IPointOfInterest pointOfInterest) : base(packState, pointOfInterest) {
            this.TextureResourceManager = TextureResourceManager.GetTextureResourceManager(pointOfInterest.ResourceManager);

            Populate(pointOfInterest.GetAggregatedAttributes(), this.TextureResourceManager);
        }

        private void Populate(AttributeCollection collection, TextureResourceManager resourceManager) {
            Populate_Guid(collection, resourceManager);
            
            Populate_Position(collection, resourceManager);
            Populate_Triggers(collection, resourceManager);
            Populate_MinMaxSize(collection, resourceManager);
            Populate_IconSize(collection, resourceManager);
            Populate_IconFile(collection, resourceManager);
            Populate_Title(collection, resourceManager);
            Populate_Tint(collection, resourceManager);
            Populate_Rotation(collection, resourceManager);
            Populate_HeightOffset(collection, resourceManager);
            Populate_Alpha(collection, resourceManager);
            Populate_FadeNearAndFar(collection, resourceManager);
            Populate_Cull(collection, resourceManager);
            Populate_MapScaling(collection, resourceManager);
            Populate_MapVisibility(collection, resourceManager);
            Populate_CanFade(collection, resourceManager);
            Populate_Tip(collection, resourceManager);

            Populate_InvertBehavior(collection, resourceManager);
            Populate_TacOMisc(collection, resourceManager);

            Populate_Behaviors(collection, resourceManager);

            // Editor Specific
            Populate_EditTag(collection, resourceManager);
        }

        public override void Update(GameTime gameTime) {
            this.DistanceToPlayer = Vector3.Distance(GameService.Gw2Mumble.PlayerCharacter.Position, this.Position);

            base.Update(gameTime);
        }

    }
}
