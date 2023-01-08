namespace ModsDude.WPF.StartupHelpers;

internal interface IAbstractFactory<T>
{
    T Create();
}