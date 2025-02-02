﻿namespace EasyCBR.Contract.IStage;

/// <summary>
/// Represents Reuse stage result.
/// </summary>
/// <typeparam name="TCase"></typeparam>
public interface IReuseStage<TCase>
    where TCase : class
{
    /// <summary>
    /// Revies the value.
    /// </summary>
    /// <param name="correctValue"></param>
    /// <returns></returns>
    IReviseStage<TCase> Revise(object correctValue);

    /// <summary>
    /// Confirms the value.
    /// </summary>
    /// <returns></returns>
    IReviseStage<TCase> Revise();

    /// <summary>
    /// Run the stage.
    /// </summary>
    /// <returns></returns>
    TCase Run();
}
