using CoreclrTestLib;
using Xunit;

namespace Interop_MarshalAPI
{
    public class _Copy_CopyCharArray_CopyCharArray_
    {
        [Fact]
        public void _Copy_CopyCharArray_CopyCharArray_cmd()
        {
            CoreclrTestWrapperLib.RunTest("Interop\\MarshalAPI\\Copy\\CopyCharArray\\CopyCharArray.cmd");
        }
    }
}
