using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_objectdisposedexception_ObjectDisposedExceptionMessage_ObjectDisposedExceptionMessage_
    {
        [OuterLoop]
        [Fact]
        public void _system_objectdisposedexception_ObjectDisposedExceptionMessage_ObjectDisposedExceptionMessage_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\objectdisposedexception\\ObjectDisposedExceptionMessage\\ObjectDisposedExceptionMessage.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
