using CoreclrTestLib;
using Xunit;

namespace JIT_Generics
{
    class _pinvoke_instance03_instance03_
    {
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [OuterLoop]
        [Fact]
        public void _pinvoke_instance03_instance03_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Generics\\pinvoke\\instance03\\instance03.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
