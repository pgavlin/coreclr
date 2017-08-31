using CoreclrTestLib;
using Xunit;

namespace JIT_Generics
{
    class _pinvoke_instance02_instance02_
    {
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [OuterLoop]
        [Fact]
        public void _pinvoke_instance02_instance02_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Generics\\pinvoke\\instance02\\instance02.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
