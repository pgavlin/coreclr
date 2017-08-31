using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _pinvoke_sin_sin_
    {
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [OuterLoop]
        [Fact]
        public void _pinvoke_sin_sin_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\pinvoke\\sin\\sin.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
