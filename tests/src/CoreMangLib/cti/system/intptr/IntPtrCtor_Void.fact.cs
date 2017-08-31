using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_intptr_IntPtrCtor_Void_IntPtrCtor_Void_
    {
        [OuterLoop]
        [Fact]
        public void _system_intptr_IntPtrCtor_Void_IntPtrCtor_Void_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\intptr\\IntPtrCtor_Void\\IntPtrCtor_Void.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
