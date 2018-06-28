// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataFactory.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// HDInsight MapReduce activity type.
    /// </summary>
    [Newtonsoft.Json.JsonObject("HDInsightMapReduce")]
    [Rest.Serialization.JsonTransformation]
    public partial class HDInsightMapReduceActivity : ExecutionActivity
    {
        /// <summary>
        /// Initializes a new instance of the HDInsightMapReduceActivity class.
        /// </summary>
        public HDInsightMapReduceActivity()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the HDInsightMapReduceActivity class.
        /// </summary>
        /// <param name="name">Activity name.</param>
        /// <param name="className">Class name. Type: string (or Expression
        /// with resultType string).</param>
        /// <param name="jarFilePath">Jar path. Type: string (or Expression
        /// with resultType string).</param>
        /// <param name="additionalProperties">Unmatched properties from the
        /// message are deserialized this collection</param>
        /// <param name="description">Activity description.</param>
        /// <param name="dependsOn">Activity depends on condition.</param>
        /// <param name="userProperties">Activity user properties.</param>
        /// <param name="linkedServiceName">Linked service reference.</param>
        /// <param name="policy">Activity policy.</param>
        /// <param name="storageLinkedServices">Storage linked service
        /// references.</param>
        /// <param name="arguments">User specified arguments to
        /// HDInsightActivity.</param>
        /// <param name="getDebugInfo">Debug info option. Possible values
        /// include: 'None', 'Always', 'Failure'</param>
        /// <param name="jarLinkedService">Jar linked service
        /// reference.</param>
        /// <param name="jarLibs">Jar libs.</param>
        /// <param name="defines">Allows user to specify defines for the
        /// MapReduce job request.</param>
        public HDInsightMapReduceActivity(string name, object className, object jarFilePath, IDictionary<string, object> additionalProperties = default(IDictionary<string, object>), string description = default(string), IList<ActivityDependency> dependsOn = default(IList<ActivityDependency>), IDictionary<string, string> userProperties = default(IDictionary<string, string>), LinkedServiceReference linkedServiceName = default(LinkedServiceReference), ActivityPolicy policy = default(ActivityPolicy), IList<LinkedServiceReference> storageLinkedServices = default(IList<LinkedServiceReference>), IList<object> arguments = default(IList<object>), string getDebugInfo = default(string), LinkedServiceReference jarLinkedService = default(LinkedServiceReference), IList<object> jarLibs = default(IList<object>), IDictionary<string, object> defines = default(IDictionary<string, object>))
            : base(name, additionalProperties, description, dependsOn, userProperties, linkedServiceName, policy)
        {
            StorageLinkedServices = storageLinkedServices;
            Arguments = arguments;
            GetDebugInfo = getDebugInfo;
            ClassName = className;
            JarFilePath = jarFilePath;
            JarLinkedService = jarLinkedService;
            JarLibs = jarLibs;
            Defines = defines;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets storage linked service references.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.storageLinkedServices")]
        public IList<LinkedServiceReference> StorageLinkedServices { get; set; }

        /// <summary>
        /// Gets or sets user specified arguments to HDInsightActivity.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.arguments")]
        public IList<object> Arguments { get; set; }

        /// <summary>
        /// Gets or sets debug info option. Possible values include: 'None',
        /// 'Always', 'Failure'
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.getDebugInfo")]
        public string GetDebugInfo { get; set; }

        /// <summary>
        /// Gets or sets class name. Type: string (or Expression with
        /// resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.className")]
        public object ClassName { get; set; }

        /// <summary>
        /// Gets or sets jar path. Type: string (or Expression with resultType
        /// string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.jarFilePath")]
        public object JarFilePath { get; set; }

        /// <summary>
        /// Gets or sets jar linked service reference.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.jarLinkedService")]
        public LinkedServiceReference JarLinkedService { get; set; }

        /// <summary>
        /// Gets or sets jar libs.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.jarLibs")]
        public IList<object> JarLibs { get; set; }

        /// <summary>
        /// Gets or sets allows user to specify defines for the MapReduce job
        /// request.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.defines")]
        public IDictionary<string, object> Defines { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (ClassName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ClassName");
            }
            if (JarFilePath == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "JarFilePath");
            }
            if (StorageLinkedServices != null)
            {
                foreach (var element in StorageLinkedServices)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
            if (JarLinkedService != null)
            {
                JarLinkedService.Validate();
            }
        }
    }
}
