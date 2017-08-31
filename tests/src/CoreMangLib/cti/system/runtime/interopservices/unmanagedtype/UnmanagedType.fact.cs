using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_runtime_interopservices_unmanagedtype_UnmanagedType_UnmanagedType_
    {
        [OuterLoop]
        [Fact]
        public void _system_runtime_interopservices_unmanagedtype_UnmanagedType_UnmanagedType_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\runtime\\interopservices\\unmanagedtype\\UnmanagedType\\UnmanagedType.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
