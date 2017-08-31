using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_outofmemoryexception_OutOfMemoryExceptionCtor3_OutOfMemoryExceptionCtor3_
    {
        [OuterLoop]
        [Fact]
        public void _system_outofmemoryexception_OutOfMemoryExceptionCtor3_OutOfMemoryExceptionCtor3_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\outofmemoryexception\\OutOfMemoryExceptionCtor3\\OutOfMemoryExceptionCtor3.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
