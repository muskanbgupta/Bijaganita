using Microsoft.AspNetCore.Mvc;
using Bijaganita.Models;
namespace Bijaganita.Controllers
{
    public class GanitaController : Controller
    {
        private readonly IConfiguration _configuration;

        public GanitaController(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View(new Ganita());
        }
        [HttpPost]
        public async Task<IActionResult> Index(Ganita Profile)
        {
            try
            {
                    switch (Profile.Formula)
                    {
               case "Radius":

    Profile.Suggestion = @"
        <h3>Formula Explanation / सूत्र की व्याख्या</h3>

        <h4>What is this formula? / यह क्या है?</h4>
        <p>Radius is the distance from the centre of a circle to its edge.</p>
        <p>त्रिज्या वृत्त के केंद्र से उसकी परिधि तक की दूरी होती है।</p>

        <h4>Formula / सूत्र</h4>
        <div class='formula'>r = radius / त्रिज्या</div>

        <h4>How to calculate / गणना कैसे करें</h4>
        <ol>
            <li>Find the centre of the circle. / वृत्त का केंद्र ज्ञात करें।</li>
            <li>Measure from the centre to the edge. / केंद्र से किनारे तक की दूरी मापें।</li>
            <li>This distance is the radius. / यही दूरी त्रिज्या कहलाती है।</li>
        </ol>

        <h4>Example / उदाहरण</h4>
        <p>If the distance from the centre to the edge is 5 cm, the radius is 5 cm.</p>
        <p>यदि केंद्र से किनारे तक की दूरी 5 सेमी है, तो त्रिज्या 5 सेमी होगी।</p>

        <h4>Quick Tip / महत्वपूर्ण बात</h4>
        <p>Diameter = 2 × Radius.</p>
        <p>व्यास = 2 × त्रिज्या।</p>
    ";

                        break;


                    case "Area Of Circle":

                        Profile.Suggestion = @"
        <h3>Formula Explanation / सूत्र की व्याख्या</h3>

        <h4>What is this formula? / यह क्या है?</h4>
        <p>The area of a circle tells us how much space is inside the circle.</p>
        <p>वृत्त का क्षेत्रफल बताता है कि वृत्त के अंदर कितना स्थान है।</p>

        <h4>Formula / सूत्र</h4>
        <div class='formula'>Area = π × r² / क्षेत्रफल = π × त्रिज्या²</div>

        <h4>How to calculate / गणना कैसे करें</h4>
        <ol>
            <li>Find the radius. / त्रिज्या ज्ञात करें।</li>
            <li>Square the radius. / त्रिज्या का वर्ग करें।</li>
            <li>Multiply it by π. / इसे π से गुणा करें।</li>
        </ol>

        <h4>Example / उदाहरण</h4>
        <p>If the radius is 5 cm, Area = π × 5² = 25π cm².</p>
        <p>यदि त्रिज्या 5 सेमी है, तो क्षेत्रफल = π × 5² = 25π सेमी²।</p>

        <h4>Quick Tip / महत्वपूर्ण बात</h4>
        <p>Remember: the radius must be squared.</p>
        <p>याद रखें: त्रिज्या का वर्ग करना आवश्यक है।</p>
    ";

                        break;


                    case "Area Of Rectangle":

                        Profile.Suggestion = @"
        <h3>Formula Explanation / सूत्र की व्याख्या</h3>

        <h4>What is this formula? / यह क्या है?</h4>
        <p>The area of a rectangle tells us how much space is inside the rectangle.</p>
        <p>आयत का क्षेत्रफल बताता है कि आयत के अंदर कितना स्थान है।</p>

        <h4>Formula / सूत्र</h4>
        <div class='formula'>Area = Length × Width / क्षेत्रफल = लंबाई × चौड़ाई</div>

        <h4>How to calculate / गणना कैसे करें</h4>
        <ol>
            <li>Find the length. / लंबाई ज्ञात करें।</li>
            <li>Find the width. / चौड़ाई ज्ञात करें।</li>
            <li>Multiply the length by the width. / लंबाई को चौड़ाई से गुणा करें।</li>
        </ol>

        <h4>Example / उदाहरण</h4>
        <p>If the length is 10 cm and the width is 5 cm, Area = 10 × 5 = 50 cm².</p>
        <p>यदि लंबाई 10 सेमी और चौड़ाई 5 सेमी है, तो क्षेत्रफल = 10 × 5 = 50 सेमी²।</p>

        <h4>Quick Tip / महत्वपूर्ण बात</h4>
        <p>Length and width must use the same unit.</p>
        <p>लंबाई और चौड़ाई की इकाई समान होनी चाहिए।</p>
    ";

                        break;


                    case "Area Of Triangle":

                        Profile.Suggestion = @"
        <h3>Formula Explanation / सूत्र की व्याख्या</h3>

        <h4>What is this formula? / यह क्या है?</h4>
        <p>The area of a triangle tells us how much space is inside the triangle.</p>
        <p>त्रिभुज का क्षेत्रफल बताता है कि त्रिभुज के अंदर कितना स्थान है।</p>

        <h4>Formula / सूत्र</h4>
        <div class='formula'>Area = ½ × Base × Height / क्षेत्रफल = ½ × आधार × ऊँचाई</div>

        <h4>How to calculate / गणना कैसे करें</h4>
        <ol>
            <li>Find the base. / आधार ज्ञात करें।</li>
            <li>Find the height. / ऊँचाई ज्ञात करें।</li>
            <li>Multiply base and height. / आधार और ऊँचाई को गुणा करें।</li>
            <li>Divide the result by 2. / प्राप्त परिणाम को 2 से भाग दें।</li>
        </ol>

        <h4>Example / उदाहरण</h4>
        <p>If the base is 10 cm and the height is 6 cm, Area = ½ × 10 × 6 = 30 cm².</p>
        <p>यदि आधार 10 सेमी और ऊँचाई 6 सेमी है, तो क्षेत्रफल = ½ × 10 × 6 = 30 सेमी²।</p>

        <h4>Quick Tip / महत्वपूर्ण बात</h4>
        <p>Always divide the base × height by 2.</p>
        <p>हमेशा आधार × ऊँचाई को 2 से भाग दें।</p>
    ";

                        break;


                    case "Area Of Square":

                        Profile.Suggestion = @"
        <h3>Formula Explanation / सूत्र की व्याख्या</h3>

        <h4>What is this formula? / यह क्या है?</h4>
        <p>The area of a square tells us how much space is inside the square.</p>
        <p>वर्ग का क्षेत्रफल बताता है कि वर्ग के अंदर कितना स्थान है।</p>

        <h4>Formula / सूत्र</h4>
        <div class='formula'>Area = Side × Side / क्षेत्रफल = भुजा × भुजा</div>

        <h4>How to calculate / गणना कैसे करें</h4>
        <ol>
            <li>Find the length of one side. / एक भुजा की लंबाई ज्ञात करें।</li>
            <li>Multiply the side by itself. / भुजा को उसी भुजा से गुणा करें।</li>
        </ol>

        <h4>Example / उदाहरण</h4>
        <p>If one side is 6 cm, Area = 6 × 6 = 36 cm².</p>
        <p>यदि एक भुजा 6 सेमी है, तो क्षेत्रफल = 6 × 6 = 36 सेमी²।</p>

        <h4>Quick Tip / महत्वपूर्ण बात</h4>
        <p>All four sides of a square are equal.</p>
        <p>वर्ग की चारों भुजाएँ बराबर होती हैं।</p>
    ";

                        break;

                }
                return View("Result", Profile);
            }
            catch (Exception ex)
            {
                Profile.Suggestion = ex.Message;

                return View("Result", Profile);
            }
        }
    }
}