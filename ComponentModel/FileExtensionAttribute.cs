/* 
 * FileExtensionAttribute.cs
 * 
 *   Created: 2023-02-25-01:44:11
 *   Modified: 2023-02-25-01:45:23
 * 
 *   Author: David G. Moore, Jr. <david@dgmjr.io>
 *   
 *   Copyright © 2022-2023 David G. Moore, Jr., All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

namespace System.ComponentModel.DataAnnotations;

/// <summary>
/// For marking an item with a file extension.
/// </summary>
[AttributeUsage(AttributeTargets.All, AllowMultiple = true, Inherited = true)]
public sealed class FileExtensionAttribute : ValueAttribute<string[]>
{
    public FileExtensionAttribute(params string[] extensions) : base((extensions.Select(extension => (!extension.StartsWith(".") ? "." : "") + extension)).ToArray()) { }

    /// <summary>
    /// The extensions with the leading dot.
    /// </summary>
    /// <value><inheritdoc cref="Extension" path="/summary/node()"/></value>
    public string[] Extensions => Value;

    /// <summary>
    /// The first extension with the leading dot.
    /// </summary>
    /// <value><inheritdoc cref="Extension" path="/summary/node()"/></value>
    public string? Extension => Value?.FirstOrDefault();
}
