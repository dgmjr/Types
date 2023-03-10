/* 
 * GuidAttribute.cs
 * 
 *   Created: 2023-02-25-01:44:11
 *   Modified: 2023-02-25-01:45:15
 * 
 *   Author: David G. Moore, Jr. <david@dgmjr.io>
 *   
 *   Copyright © 2022-2023 David G. Moore, Jr., All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

namespace System.ComponentModel.DataAnnotations;

public sealed class GuidAttribute : ValueAttribute<Guid>
{
    public GuidAttribute(string guid) : this(Guid.Parse(guid)) { }
    public GuidAttribute(Guid guid) : base(guid) { }

    public Guid Guid => Value;
}
