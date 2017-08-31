using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_outofmemoryexception_OutOfMemoryExceptionCtor2_OutOfMemoryExceptionCtor2_
    {
        [OuterLoop]
        [Fact]
        public void _system_outofmemoryexception_OutOfMemoryExceptionCtor2_OutOfMemoryExceptionCtor2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\outofmemoryexception\\OutOfMemoryExceptionCtor2\\OutOfMemoryExceptionCtor2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
