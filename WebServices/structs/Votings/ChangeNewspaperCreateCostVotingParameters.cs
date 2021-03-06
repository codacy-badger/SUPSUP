﻿using Entities;
using Entities.enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebServices.structs.Votings
{
    public class ChangeNewspaperCreateCostVotingParameters : StartCongressVotingParameters
    {
        public double CreateCost { get; set; }

        public override VotingTypeEnum VotingType { protected set; get; } = VotingTypeEnum.ChangeNewspaperCreateCost;

        public ChangeNewspaperCreateCostVotingParameters(double createCost)
        {
            CreateCost = createCost;
        }

        public override void FillCongressVotingArguments(CongressVoting voting)
        {
            voting.Argument1 = CreateCost.ToString();
        }
    }
}
