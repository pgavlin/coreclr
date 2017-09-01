using CoreclrTestLib;
using Xunit;

namespace Interop_MarshalAPI
{
    public class _Copy_CopyIntPtrArray_CopyIntPtrArray_
    {
        [Fact]
        public void _Copy_CopyIntPtrArray_CopyIntPtrArray_cmd()
        {
            CoreclrTestWrapperLib.RunTest("Interop\\MarshalAPI\\Copy\\CopyIntPtrArray\\CopyIntPtrArray.cmd");
        }
    }
}
