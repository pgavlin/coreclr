using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_uintptr_UIntPtrCtor_UInt32_UIntPtrCtor_UInt32_
    {
        [OuterLoop]
        [Fact]
        public void _system_uintptr_UIntPtrCtor_UInt32_UIntPtrCtor_UInt32_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\uintptr\\UIntPtrCtor_UInt32\\UIntPtrCtor_UInt32.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
