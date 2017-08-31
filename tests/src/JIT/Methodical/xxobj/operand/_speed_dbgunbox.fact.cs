using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _xxobj_operand__speed_dbgunbox__speed_dbgunbox_
    {
        [OuterLoop]
        [Fact]
        public void _xxobj_operand__speed_dbgunbox__speed_dbgunbox_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\xxobj\\operand\\_speed_dbgunbox\\_speed_dbgunbox.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
