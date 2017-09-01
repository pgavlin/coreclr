using CoreclrTestLib;
using Xunit;

namespace GC_API
{
    public class _GCHandle_Weak_Weak_
    {
        [OuterLoop]
        [Fact]
        public void _GCHandle_Weak_Weak_cmd()
        {
            CoreclrTestWrapperLib.RunTest("GC\\API\\GCHandle\\Weak\\Weak.cmd");
        }
    }
}
