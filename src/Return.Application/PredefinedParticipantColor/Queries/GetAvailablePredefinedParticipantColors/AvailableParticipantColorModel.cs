﻿// ******************************************************************************
//  ©  Sebastiaan Dammann | damsteen.nl
// 
//  File:           : AvailableParticipantColorModel.cs
//  Project         : Return.Application
// ******************************************************************************

namespace Return.Application.PredefinedParticipantColor.Queries.GetAvailablePredefinedParticipantColors {
    using System;
    using AutoMapper;
    using Common.Mapping;
    using Common.Models;
    using Domain.Entities;

#nullable disable

    public class AvailableParticipantColorModel : ColorModel, IMapFrom<PredefinedParticipantColor> {
        public string Name { get; set; }

        public override void Mapping(Profile profile) {
            if (profile == null) throw new ArgumentNullException(nameof(profile));

            profile.CreateMap<PredefinedParticipantColor, AvailableParticipantColorModel>().
                ForMember(e => e.R, m => m.MapFrom(e => e.Color.R)).
                ForMember(e => e.B, m => m.MapFrom(e => e.Color.B)).
                ForMember(e => e.G, m => m.MapFrom(e => e.Color.G));
        }
    }
}