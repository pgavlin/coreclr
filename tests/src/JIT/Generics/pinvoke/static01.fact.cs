using CoreclrTestLib;
using Xunit;

namespace JIT_Generics
{
    public class _pinvoke_static01_static01_
    {
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [OuterLoop]
        [Fact]
        public void _pinvoke_static01_static01_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Generics\\pinvoke\\static01\\static01.cmd");
        }
    }
}
