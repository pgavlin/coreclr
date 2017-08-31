using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_outofmemoryexception_OutOfMemoryExceptionCtor1_OutOfMemoryExceptionCtor1_
    {
        [OuterLoop]
        [Fact]
        public void _system_outofmemoryexception_OutOfMemoryExceptionCtor1_OutOfMemoryExceptionCtor1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\outofmemoryexception\\OutOfMemoryExceptionCtor1\\OutOfMemoryExceptionCtor1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
