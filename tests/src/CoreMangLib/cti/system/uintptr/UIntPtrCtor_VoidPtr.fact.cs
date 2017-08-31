using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_uintptr_UIntPtrCtor_VoidPtr_UIntPtrCtor_VoidPtr_
    {
        [OuterLoop]
        [Fact]
        public void _system_uintptr_UIntPtrCtor_VoidPtr_UIntPtrCtor_VoidPtr_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\uintptr\\UIntPtrCtor_VoidPtr\\UIntPtrCtor_VoidPtr.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
