using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _StructPromote_SP2c_SP2c_
    {
        [OuterLoop]
        [Fact]
        public void _StructPromote_SP2c_SP2c_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\StructPromote\\SP2c\\SP2c.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
