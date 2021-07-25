// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.MachineLearningServices.Models
{
    /// <summary> Early termination policies enable canceling poor-performing runs before they complete. </summary>
    public partial class EarlyTerminationPolicy
    {
        /// <summary> Initializes a new instance of EarlyTerminationPolicy. </summary>
        public EarlyTerminationPolicy()
        {
        }

        /// <summary> Initializes a new instance of EarlyTerminationPolicy. </summary>
        /// <param name="delayEvaluation"></param>
        /// <param name="evaluationInterval"></param>
        /// <param name="policyType"> Name of policy configuration. </param>
        internal EarlyTerminationPolicy(int? delayEvaluation, int? evaluationInterval, EarlyTerminationPolicyType policyType)
        {
            DelayEvaluation = delayEvaluation;
            EvaluationInterval = evaluationInterval;
            PolicyType = policyType;
        }

        public int? DelayEvaluation { get; set; }
        public int? EvaluationInterval { get; set; }
        /// <summary> Name of policy configuration. </summary>
        internal EarlyTerminationPolicyType PolicyType { get; set; }
    }
}
