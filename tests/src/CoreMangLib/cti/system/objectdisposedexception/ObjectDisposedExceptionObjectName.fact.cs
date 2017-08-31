using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_objectdisposedexception_ObjectDisposedExceptionObjectName_ObjectDisposedExceptionObjectName_
    {
        [OuterLoop]
        [Fact]
        public void _system_objectdisposedexception_ObjectDisposedExceptionObjectName_ObjectDisposedExceptionObjectName_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\objectdisposedexception\\ObjectDisposedExceptionObjectName\\ObjectDisposedExceptionObjectName.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
