using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _pinvoke_tail_tail_
    {
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [Fact]
        public void _pinvoke_tail_tail_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\pinvoke\\tail\\tail.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
