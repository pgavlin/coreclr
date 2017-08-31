using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _xxobj_ldobj__il_relldobj_V__il_relldobj_V_
    {
        [OuterLoop]
        [Fact]
        public void _xxobj_ldobj__il_relldobj_V__il_relldobj_V_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\xxobj\\ldobj\\_il_relldobj_V\\_il_relldobj_V.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
