using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _xxobj_ldobj__il_relldobj_R4__il_relldobj_R4_
    {
        [OuterLoop]
        [Fact]
        public void _xxobj_ldobj__il_relldobj_R4__il_relldobj_R4_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\xxobj\\ldobj\\_il_relldobj_R4\\_il_relldobj_R4.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
