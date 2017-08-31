using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_intptr_IntPtrCtor_Int32_IntPtrCtor_Int32_
    {
        [OuterLoop]
        [Fact]
        public void _system_intptr_IntPtrCtor_Int32_IntPtrCtor_Int32_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\intptr\\IntPtrCtor_Int32\\IntPtrCtor_Int32.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
