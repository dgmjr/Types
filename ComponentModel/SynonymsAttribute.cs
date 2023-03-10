/* 
 * SynonymsAttribute.cs
 * 
 *   Created: 2023-02-25-01:44:11
 *   Modified: 2023-02-25-01:45:07
 * 
 *   Author: David G. Moore, Jr. <david@dgmjr.io>
 *   
 *   Copyright © 2022-2023 David G. Moore, Jr., All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

namespace System.ComponentModel.DataAnnotations;

public sealed class SynonymsAttribute : ValueAttribute<string[]>
{
    public SynonymsAttribute(params string[] synonyms)
        : base(synonyms)
    {
    }

    public string[] Synonyms => Value;
}
