using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _xxobj_ldobj__il_dbgldobj_I__il_dbgldobj_I_
    {
        [OuterLoop]
        [Fact]
        public void _xxobj_ldobj__il_dbgldobj_I__il_dbgldobj_I_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\xxobj\\ldobj\\_il_dbgldobj_I\\_il_dbgldobj_I.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
