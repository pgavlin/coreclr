using CoreclrTestLib;
using Xunit;

namespace GC_API
{
    public class _GCHandle_Alloc_neg_Alloc_neg_
    {
        [OuterLoop]
        [Fact]
        public void _GCHandle_Alloc_neg_Alloc_neg_cmd()
        {
            CoreclrTestWrapperLib.RunTest("GC\\API\\GCHandle\\Alloc_neg\\Alloc_neg.cmd");
        }
    }
}
