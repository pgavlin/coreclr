using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _xxobj_ldobj__il_dbgldobj_I8__il_dbgldobj_I8_
    {
        [OuterLoop]
        [Fact]
        public void _xxobj_ldobj__il_dbgldobj_I8__il_dbgldobj_I8_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\xxobj\\ldobj\\_il_dbgldobj_I8\\_il_dbgldobj_I8.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
