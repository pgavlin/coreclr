using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _StructPromote_SP1a_SP1a_
    {
        [OuterLoop]
        [Fact]
        public void _StructPromote_SP1a_SP1a_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\StructPromote\\SP1a\\SP1a.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
