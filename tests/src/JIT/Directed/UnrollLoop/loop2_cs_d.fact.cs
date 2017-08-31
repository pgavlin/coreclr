using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _UnrollLoop_loop2_cs_d_loop2_cs_d_
    {
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [OuterLoop]
        [Fact]
        public void _UnrollLoop_loop2_cs_d_loop2_cs_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\UnrollLoop\\loop2_cs_d\\loop2_cs_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
