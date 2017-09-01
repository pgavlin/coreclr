using CoreclrTestLib;
using Xunit;

namespace Interop_StructMarshalling
{
    public class _PInvoke_MarshalStructAsLayoutSeq_MarshalStructAsLayoutSeq_
    {
        [Fact]
        public void _PInvoke_MarshalStructAsLayoutSeq_MarshalStructAsLayoutSeq_cmd()
        {
            CoreclrTestWrapperLib.RunTest("Interop\\StructMarshalling\\PInvoke\\MarshalStructAsLayoutSeq\\MarshalStructAsLayoutSeq.cmd");
        }
    }
}
