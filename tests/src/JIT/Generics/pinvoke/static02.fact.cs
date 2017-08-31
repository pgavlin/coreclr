using CoreclrTestLib;
using Xunit;

namespace JIT_Generics
{
    class _pinvoke_static02_static02_
    {
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [OuterLoop]
        [Fact]
        public void _pinvoke_static02_static02_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Generics\\pinvoke\\static02\\static02.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
