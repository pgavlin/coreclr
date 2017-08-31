using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_intptr_IntPtrCtor_Int64_IntPtrCtor_Int64_
    {
        [OuterLoop]
        [Fact]
        public void _system_intptr_IntPtrCtor_Int64_IntPtrCtor_Int64_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\intptr\\IntPtrCtor_Int64\\IntPtrCtor_Int64.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
