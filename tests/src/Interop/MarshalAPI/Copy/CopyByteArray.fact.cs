using CoreclrTestLib;
using Xunit;

namespace Interop_MarshalAPI
{
    public class _Copy_CopyByteArray_CopyByteArray_
    {
        [Fact]
        public void _Copy_CopyByteArray_CopyByteArray_cmd()
        {
            CoreclrTestWrapperLib.RunTest("Interop\\MarshalAPI\\Copy\\CopyByteArray\\CopyByteArray.cmd");
        }
    }
}
