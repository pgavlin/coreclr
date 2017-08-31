using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _xxobj_ldobj__il_relldobj_R8__il_relldobj_R8_
    {
        [OuterLoop]
        [Fact]
        public void _xxobj_ldobj__il_relldobj_R8__il_relldobj_R8_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\xxobj\\ldobj\\_il_relldobj_R8\\_il_relldobj_R8.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
