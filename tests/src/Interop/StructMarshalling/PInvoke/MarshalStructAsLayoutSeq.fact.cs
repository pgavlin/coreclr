using CoreclrTestLib;
using Xunit;

namespace Interop_StructMarshalling
{
    class _PInvoke_MarshalStructAsLayoutSeq_MarshalStructAsLayoutSeq_
    {
        [Fact]
        public void _PInvoke_MarshalStructAsLayoutSeq_MarshalStructAsLayoutSeq_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Interop\\StructMarshalling\\PInvoke\\MarshalStructAsLayoutSeq\\MarshalStructAsLayoutSeq.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
