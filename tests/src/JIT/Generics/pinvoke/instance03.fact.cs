using CoreclrTestLib;
using Xunit;

namespace JIT_Generics
{
    public class _pinvoke_instance03_instance03_
    {
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [OuterLoop]
        [Fact]
        public void _pinvoke_instance03_instance03_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Generics\\pinvoke\\instance03\\instance03.cmd");
        }
    }
}
