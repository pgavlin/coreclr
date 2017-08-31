using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _StructPromote_SP1c_SP1c_
    {
        [OuterLoop]
        [Fact]
        public void _StructPromote_SP1c_SP1c_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\StructPromote\\SP1c\\SP1c.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
